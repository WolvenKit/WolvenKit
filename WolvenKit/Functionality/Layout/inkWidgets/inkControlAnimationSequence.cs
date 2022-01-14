using System;
using System.Collections.Generic;
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
            {
                return;
            }

            Storyboard = new();
            Storyboard.RepeatBehavior = RepeatBehavior.Forever;
            //Storyboard.Duration = new Duration(TimeSpan.FromSeconds(2));
            //Storyboard.AutoReverse = true;


            for (var i = 0; i < Sequence.Targets.Count; i++)
            {
                var info = (inkanimSequenceTargetInfo)Sequence.Targets[i].GetValue();

                if (info == null)
                {
                    continue;
                }

                var element = Root;
                foreach (var index in info.Path)
                {
                    if (element is inkCompoundControl cc)
                    {
                        element = cc.GetChild(Convert.ToInt32(index));
                    }
                }

                if (element == null)
                {
                    continue;
                }

                Targets.Add(element);

                var animDef = (inkanimDefinition)Sequence.Definitions[i].GetValue();
                foreach (var animIHandle in animDef.Interpolators)
                {
                    var animI = (inkanimInterpolator)animIHandle.GetValue();
                    List<AnimationTimeline> anims = new();
                    List<PropertyPath> paths = new();
                    object target = element;

                    if (animI is inkanimTransparencyInterpolator animTrnsp)
                    {
                        var d = new DoubleAnimationUsingKeyFrames();
                        if (animI.StartDelay != 0)
                        {
                            d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsp.StartValue, 0));
                        }
                        d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsp.StartValue, animTrnsp.StartDelay));
                        d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsp.EndValue, animTrnsp.StartDelay + animTrnsp.Duration));

                        anims.Add(d);
                        paths.Add(new PropertyPath(UIElement.OpacityProperty));
                        target = "element" + element.GetHashCode();
                    }

                    if (animI is inkanimMarginInterpolator animMargin)
                    {
                        var d = new ThicknessAnimationUsingKeyFrames();
                        if (animI.StartDelay != 0)
                        {
                            d.KeyFrames.Add(ToThicknessKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animMargin.StartValue, 0));
                        }
                        d.KeyFrames.Add(ToThicknessKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animMargin.StartValue, animMargin.StartDelay));
                        d.KeyFrames.Add(ToThicknessKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animMargin.EndValue, animMargin.StartDelay + animMargin.Duration));

                        anims.Add(d);
                        paths.Add(new PropertyPath(inkControl.MarginProperty));
                        target = "element" + element.GetHashCode();
                    }

                    if (animI is inkanimRotationInterpolator animRot)
                    {
                        var d = new DoubleAnimationUsingKeyFrames();
                        if (animI.StartDelay != 0)
                        {
                            d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animRot.StartValue, 0));
                        }
                        d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animRot.StartValue, animRot.StartDelay));
                        d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animRot.EndValue, animRot.StartDelay + animRot.Duration));

                        anims.Add(d);
                        paths.Add(new PropertyPath(RotateTransform.AngleProperty));
                        target = "rotation" + element.GetHashCode();
                    }

                    if (animI is inkanimTranslationInterpolator animTrnsl)
                    {
                        var d = new DoubleAnimationUsingKeyFrames();
                        if (animI.StartDelay != 0)
                        {
                            d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsl.StartValue.X, 0));
                        }
                        d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsl.StartValue.X, animTrnsl.StartDelay));
                        d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsl.EndValue.X, animTrnsl.StartDelay + animTrnsl.Duration));

                        anims.Add(d);
                        paths.Add(new PropertyPath(TranslateTransform.XProperty));

                        if (animI.StartDelay != 0)
                        {
                            d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsl.StartValue.Y, 0));
                        }
                        d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsl.StartValue.Y, animTrnsl.StartDelay));
                        d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsl.EndValue.Y, animTrnsl.StartDelay + animTrnsl.Duration));

                        anims.Add(d);
                        paths.Add(new PropertyPath(TranslateTransform.YProperty));

                        target = "translation" + element.GetHashCode();
                    }

                    if (animI is inkanimScaleInterpolator animScale)
                    {
                        var d = new DoubleAnimationUsingKeyFrames();
                        if (animI.StartDelay != 0)
                        {
                            d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animScale.StartValue.X, 0));
                        }
                        d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animScale.StartValue.X, animScale.StartDelay));
                        d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animScale.EndValue.X, animScale.StartDelay + animScale.Duration));

                        anims.Add(d);
                        paths.Add(new PropertyPath(ScaleTransform.ScaleXProperty));

                        if (animI.StartDelay != 0)
                        {
                            d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animScale.StartValue.Y, 0));
                        }
                        d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animScale.StartValue.Y, animScale.StartDelay));
                        d.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animScale.EndValue.Y, animScale.StartDelay + animScale.Duration));

                        anims.Add(d);
                        paths.Add(new PropertyPath(ScaleTransform.ScaleYProperty));

                        target = "scale" + element.GetHashCode();
                    }

                    foreach (var anim in anims)
                    {
                        anim.FillBehavior = FillBehavior.HoldEnd;
                        Storyboard.Children.Add(anim);
                        if (target is string targetName)
                        {
                            Storyboard.SetTargetName(anim, targetName);
                        }
                        else
                        {
                            Storyboard.SetTarget(anim, (DependencyObject)target);
                        }
                        Storyboard.SetTargetProperty(anim, paths[anims.IndexOf(anim)]);
                    }
                }
            }
        }

        public ICommand PlayCommand { get; set; }
        //public bool CanPlay() => Storyboard != null && Storyboard.GetCurrentState() == ClockState.Stopped;
        public void Play() => Storyboard.Begin(Root.WidgetView, true);

        public ICommand StopCommand { get; set; }
        //public bool CanStop() => Storyboard != null && Storyboard.GetCurrentState() != ClockState.Stopped;
        public void Stop() => Storyboard.Stop(Root.WidgetView);

        public static DoubleKeyFrame ToDoubleKeyframe(Enums.inkanimInterpolationType? type, Enums.inkanimInterpolationMode? mode, float value, float keyframe)
        {
            switch (type)
            {
                case Enums.inkanimInterpolationType.Linear:
                    return new LinearDoubleKeyFrame(value, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)));
                case Enums.inkanimInterpolationType.Quadratic:
                    return new EasingDoubleKeyFrame(value, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new QuadraticEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Qubic:
                    return new EasingDoubleKeyFrame(value, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new CubicEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Quartic:
                    return new EasingDoubleKeyFrame(value, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new QuarticEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Quintic:
                    return new EasingDoubleKeyFrame(value, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new QuinticEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Sinusoidal:
                    return new EasingDoubleKeyFrame(value, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new SineEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Exponential:
                    return new EasingDoubleKeyFrame(value, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new ExponentialEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Elastic:
                    return new EasingDoubleKeyFrame(value, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new ElasticEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Circular:
                    return new EasingDoubleKeyFrame(value, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new CircleEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Back:
                    return new EasingDoubleKeyFrame(value, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new BackEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                default:
                    return null;
            }
        }
        public static ThicknessKeyFrame ToThicknessKeyframe(Enums.inkanimInterpolationType? type, Enums.inkanimInterpolationMode? mode, inkMargin value, float keyframe)
        {
            switch (type)
            {
                case Enums.inkanimInterpolationType.Linear:
                    return new LinearThicknessKeyFrame(inkControl.ToThickness(value), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)));
                case Enums.inkanimInterpolationType.Quadratic:
                    return new EasingThicknessKeyFrame(inkControl.ToThickness(value), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new QuadraticEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Qubic:
                    return new EasingThicknessKeyFrame(inkControl.ToThickness(value), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new CubicEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Quartic:
                    return new EasingThicknessKeyFrame(inkControl.ToThickness(value), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new QuarticEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Quintic:
                    return new EasingThicknessKeyFrame(inkControl.ToThickness(value), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new QuinticEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Sinusoidal:
                    return new EasingThicknessKeyFrame(inkControl.ToThickness(value), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new SineEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Exponential:
                    return new EasingThicknessKeyFrame(inkControl.ToThickness(value), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new ExponentialEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Elastic:
                    return new EasingThicknessKeyFrame(inkControl.ToThickness(value), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new ElasticEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Circular:
                    return new EasingThicknessKeyFrame(inkControl.ToThickness(value), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new CircleEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                case Enums.inkanimInterpolationType.Back:
                    return new EasingThicknessKeyFrame(inkControl.ToThickness(value), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(keyframe)))
                    {
                        EasingFunction = new BackEase()
                        {
                            EasingMode = ToEasingMode(mode)
                        }
                    };
                default:
                    return null;
            }
        }

        public static EasingMode ToEasingMode(Enums.inkanimInterpolationMode? mode)
        {
            switch (mode)
            {
                case Enums.inkanimInterpolationMode.EasyOut:
                    return EasingMode.EaseOut;
                case Enums.inkanimInterpolationMode.EasyInOut:
                case Enums.inkanimInterpolationMode.EasyOutIn:
                    return EasingMode.EaseInOut;
                case Enums.inkanimInterpolationMode.EasyIn:
                default:
                    return EasingMode.EaseIn;
            }
        }
    }
}
