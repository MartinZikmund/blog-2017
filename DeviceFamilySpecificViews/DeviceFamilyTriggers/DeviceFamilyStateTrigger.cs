using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceFamilyHelpers;

namespace DeviceFamilyTriggers
{
    // Copyright (c) Morten Nielsen. All rights reserved.
    // Licensed under the MIT license. See LICENSE file in the project root for full license information.

    using System;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    namespace WindowsStateTriggers
    {
        /// <summary>
        /// Trigger to differentiate between device families
        /// </summary>
        public class DeviceFamilyStateTrigger : StateTriggerBase
        {
            public static readonly DependencyProperty TargetDeviceFamilyProperty = DependencyProperty.Register(
                "TargetDeviceFamily", typeof(DeviceFamily), typeof(DeviceFamilyStateTrigger), new PropertyMetadata(default(DeviceFamily), OnDeviceTypePropertyChanged));

            public DeviceFamily TargetDeviceFamily
            {
                get { return (DeviceFamily)GetValue(TargetDeviceFamilyProperty); }
                set { SetValue(TargetDeviceFamilyProperty, value); }
            }

            private static void OnDeviceTypePropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgs)
            {
                var trigger = (DeviceFamilyStateTrigger)dependencyObject;
                var newTargetDeviceFamily = (DeviceFamily)eventArgs.NewValue;
                trigger.SetActive(newTargetDeviceFamily == DeviceFamilyHelper.DeviceFamily);
            }         
        }
    }
}
