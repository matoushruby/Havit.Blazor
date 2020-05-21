﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havit.Blazor.Components.Web.Bootstrap
{
    public partial class HxListLayout
    {
        [Parameter]
        public bool FilterDrawerOpen { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        // TODO: TitleTemplate nebo TitleSection? Bude mít vůbec význam?
        public RenderFragment TitleSection { get; set; }

        [Parameter]
        // TODO: QuickSearchSection?
        public RenderFragment SearchSection { get; set; }

        [Parameter]
        // TODO: Search (předchozí) vs. Filter (zde)
        public RenderFragment FilterSection { get; set; }

        [Parameter]
        public RenderFragment NamedViewsSection { get; set; }

        public bool DetailDrawerOpen { get; set; }

        [Parameter]
        public RenderFragment DataSection { get; set; }

        [Parameter]
        public RenderFragment DetailSection { get; set; }

        [Parameter]
        public RenderFragment CommandsSection { get; set; }

        private void ToggleFilterDrawer()
        {
            FilterDrawerOpen = !FilterDrawerOpen;
        }

        private void ToggleDetailDrawer()
        {
            DetailDrawerOpen = !DetailDrawerOpen;
        }
    }
}
