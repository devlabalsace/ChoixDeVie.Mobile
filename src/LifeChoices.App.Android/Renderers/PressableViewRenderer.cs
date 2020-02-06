using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using LifeChoices.App.Content.Scenarios.OtherLogin.Controls;
using LifeChoices.App.Droid.Renderers;

[assembly: ExportRenderer(typeof(PressableView), typeof(PressableViewRenderer))]
namespace LifeChoices.App.Droid.Renderers
{
    public class PressableViewRenderer : VisualElementRenderer<PressableView>
    {
        public PressableViewRenderer(Context context) : base(context)
        {
            Touch += Control_Touch;
        }

        private void Control_Touch(object sender, TouchEventArgs e)
        {
            switch (e.Event.Action)
            {
                case MotionEventActions.Down:
                    Element?.RaisePressed();
                    break;

                case MotionEventActions.Up:
                    Element?.RaiseReleased();
                    break;

                default:
                    break;
            }

        }
    }
}
