using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace Calculator.NeumorphismControls
{
    [ContentProperty("Children")]
    public partial class NeumorphismButton : UserControl
    {
        public event RoutedEventHandler Click;

        public static readonly DependencyProperty CommandProperty =
        DependencyProperty.Register(
        "Command", typeof(ICommand),
        typeof(NeumorphismButton)
        );
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        object commandParameter = null;
        public object CommandParameter { get => commandParameter; set => commandParameter = value; }

        public static readonly DependencyPropertyKey ChildrenProperty = 
        DependencyProperty.RegisterReadOnly(
        "Children",
        typeof(UIElementCollection),
        typeof(NeumorphismButton),
        new PropertyMetadata()
        );
        public UIElementCollection Children
        {
            get { return (UIElementCollection)GetValue(ChildrenProperty.DependencyProperty); }
            private set { SetValue(ChildrenProperty, value); }
        }

        public NeumorphismButton()
        {
            InitializeComponent();
            Children = MainLayout.Children;
            MouseDown += (sender, e) =>
            {
                Click?.Invoke(sender, e);
                Command?.Execute(commandParameter);
            };
        }
    }
}
