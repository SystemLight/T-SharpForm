using System.ComponentModel;

namespace SharpForm.Components
{
    public partial class Hello : Component
    {
        public Hello() {
            InitializeComponent();
        }

        public Hello(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }
    }
}