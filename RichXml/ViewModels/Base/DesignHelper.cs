using System;
using System.ComponentModel;
using System.Windows;

namespace RichXml.ViewModels
{
    internal class DesignHelper
    {
        private static bool? isInDesignMode;

        /// <summary>
        /// Gets a value indicating whether the control is in design mode (running in Blend
        /// or Visual Studio).
        /// </summary>
        public static bool IsInDesignMode
        {
            get
            {
                if (!isInDesignMode.HasValue)
                {
                    var prop = DesignerProperties.IsInDesignModeProperty;
                    isInDesignMode
                        = (bool)DependencyPropertyDescriptor
                            .FromProperty(prop, typeof(FrameworkElement))
                            .Metadata.DefaultValue;
                }
                return isInDesignMode.Value;
            }
        }
    }
}