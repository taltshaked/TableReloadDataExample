using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AntDesignExample.Helpers
{
    /// <summary>
    /// Specialized custom validator component to trigger an external function on validation
    /// </summary>
    public class DelegatingCustomValidator : ComponentBase
    {
        [CascadingParameter]
        private EditContext CurrentEditContext { get; set; }

        [Parameter]
        public Action OnFieldChanged { get; set; }

        protected override void OnInitialized()
        {
            CurrentEditContext.OnFieldChanged += (s, e) => OnFieldChanged();
        }
    }
}
