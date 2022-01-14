using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using WolvenKit.Functionality.Commands;
using WolvenKit.RED4.Types;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkControlAnimation
    {
        public string Name => Sequence.Name;
        public inkanimSequence Sequence { get; set; }
        public inkControl Root { get; set; }
        public List<inkControl> Targets { get; set; } = new();
        public Storyboard Storyboard { get; set; }

        public inkControlAnimation(inkanimSequence seq, inkControl root)
        {
            Sequence = seq;
            Root = root;

            //PlayCommand = new RelayCommand(Play, CanPlay);
            //StopCommand = new RelayCommand(Stop, CanStop);
            PlayCommand = new RelayCommand(Play);
            StopCommand = new RelayCommand(Stop);

            if (Sequence.Targets.Count != Sequence.Definitions.Count)
                return;

            Storyboard = new();

            for (var i = 0; i < Sequence.Targets.Count; i++)
            {
                var info = (inkanimSequenceTargetInfo)Sequence.Targets[i].GetValue();

                var element = Root;
                foreach (var index in info.Path)
                {
                    if (element is inkCompoundControl cc)
                        element = cc.GetChild(Convert.ToInt32(index));
                }

                if (element == null)
                    continue;

                Targets.Add(element);

                var animDef = (inkanimDefinition)Sequence.Definitions[i].GetValue();
                foreach (var animIHandle in animDef.Interpolators)
                {
                    var animI = (inkanimInterpolator)animIHandle.GetValue();
                    List<AnimationTimeline> anims = new();
                    List<PropertyPath> paths = new();
                    DependencyObject target = element;

                    if (animI is inkanimTransparencyInterpolator animTrnsp)
                    {
                        anims.Add(new DoubleAnimation()
                        {
                            From = animTrnsp.StartValue,
                            To = animTrnsp.EndValue
                        });
                        paths.Add(new PropertyPath(UIElement.OpacityProperty));
                    }

                    if (animI is inkanimRotationInterpolator animRot)
                    {
                        anims.Add(new DoubleAnimation()
                        {
                            From = animRot.StartValue,
                            To = animRot.EndValue
                        });
                        paths.Add(new PropertyPath(RotateTransform.AngleProperty));
                        target = element.Rotation;
                    }

                    if (animI is inkanimTranslationInterpolator animTrnsl)
                    {
                        anims.Add(new DoubleAnimation()
                        {
                            From = animTrnsl.StartValue.X,
                            To = animTrnsl.EndValue.X
                        });
                        paths.Add(new PropertyPath(TranslateTransform.XProperty));

                        anims.Add(new DoubleAnimation()
                        {
                            From = animTrnsl.StartValue.Y,
                            To = animTrnsl.EndValue.Y
                        });
                        paths.Add(new PropertyPath(TranslateTransform.YProperty));

                        target = element.Rotation;
                    }

                    if (animI is inkanimScaleInterpolator animScale)
                    {
                        anims.Add(new DoubleAnimation()
                        {
                            From = animScale.StartValue.X,
                            To = animScale.EndValue.X
                        });
                        paths.Add(new PropertyPath(ScaleTransform.ScaleXProperty));

                        anims.Add(new DoubleAnimation()
                        {
                            From = animScale.StartValue.Y,
                            To = animScale.EndValue.Y
                        });
                        paths.Add(new PropertyPath(ScaleTransform.ScaleYProperty));

                        target = element.Scale;
                    }

                    foreach (var anim in anims)
                    {
                        anim.Duration = new Duration(TimeSpan.FromSeconds(animI.Duration));
                        //anim.EasingFunction = ti.InterpolationType;
                        anim.BeginTime = TimeSpan.FromSeconds(animI.StartDelay);
                        anim.RepeatBehavior = RepeatBehavior.Forever;
                        Storyboard.Children.Add(anim);
                        Storyboard.SetTarget(anim, target);
                        Storyboard.SetTargetProperty(anim, paths[anims.IndexOf(anim)]);
                    }
                }
            }
        }

        public ICommand PlayCommand { get; set; }
        //public bool CanPlay() => Storyboard != null && Storyboard.GetCurrentState() == ClockState.Stopped;
        public void Play() => Storyboard.Begin();

        public ICommand StopCommand { get; set; }
        //public bool CanStop() => Storyboard != null && Storyboard.GetCurrentState() != ClockState.Stopped;
        public void Stop() => Storyboard.Stop();
    }
}
