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
using WolvenKit.Views.Documents;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkControlAnimationDefiniton
    {
        public inkanimInterpolator Interpolator;
        public List<AnimationTimeline> Timelines;
        public List<PropertyPath> Paths;
        public string Target;
    }

    public class inkControlAnimation
    {
        public string Name => Sequence.Name;
        public inkanimSequence Sequence { get; set; }
        public RDTWidgetView WidgetView { get; set; }
        public List<inkControl> Targets { get; set; } = new();
        public Storyboard Storyboard { get; set; }

        public inkControlAnimation(inkanimSequence seq, RDTWidgetView wv)
        {
            Sequence = seq;
            WidgetView = wv;

            //PlayCommand = new RelayCommand(Play, CanPlay);
            //StopCommand = new RelayCommand(Stop, CanStop);
            PlayCommand = new RelayCommand(Play);
            StopCommand = new RelayCommand(Stop);

            if (Sequence.Targets.Count != Sequence.Definitions.Count)
                return;

            Storyboard = new();
            if (Name.Contains("loop"))
            {
                Storyboard.RepeatBehavior = RepeatBehavior.Forever;
            }
            //Storyboard.Duration = new Duration(TimeSpan.FromSeconds(2));
            //Storyboard.AutoReverse = true;


            for (var i = 0; i < Sequence.Targets.Count; i++)
            {
                var info = (inkanimSequenceTargetInfo)Sequence.Targets[i].GetValue();

                if (info == null)
                {
                    continue;
                }

                foreach (var root in WidgetView.Widgets)
                {
                    var element = root;
                    foreach (var index in info.Path)
                    {
                        if (element is inkCompoundControl cc)
                            element = cc.GetChild(Convert.ToInt32(index));
                    }

                    if (element == null)
                        continue;

                    Targets.Add(element);

                    var definitions = new List<inkControlAnimationDefiniton>();

                    var animDef = (inkanimDefinition)Sequence.Definitions[i].GetValue();
                    foreach (var animIHandle in animDef.Interpolators)
                    {
                        var animI = (inkanimInterpolator)animIHandle.GetValue();

                        if (animI is inkanimTransparencyInterpolator animTrnsp)
                        {
                            DoubleAnimationUsingKeyFrames timeline = null;
                            var definition = definitions.Where(x => x.Interpolator is inkanimTransparencyInterpolator).FirstOrDefault(defaultValue: null);

                            if (definition == null)
                            {
                                timeline = new DoubleAnimationUsingKeyFrames();
                                definitions.Add(new inkControlAnimationDefiniton()
                                {
                                    Interpolator = animTrnsp,
                                    Timelines = new List<AnimationTimeline>(new[] { timeline }),
                                    Paths = new List<PropertyPath>(new[] { new PropertyPath(UIElement.OpacityProperty) }),
                                    Target = "element" + element.GetHashCode()
                                });
                            } else
                            {
                                timeline = (DoubleAnimationUsingKeyFrames)definition.Timelines[0];
                            }

                            if (animI.StartDelay != 0)
                            {
                                timeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsp.StartValue, 0));
                            }
                            timeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsp.StartValue, animTrnsp.StartDelay));
                            timeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsp.EndValue, animTrnsp.StartDelay + animTrnsp.Duration));
                        }

                        if (animI is inkanimMarginInterpolator animMargin)
                        {
                            ThicknessAnimationUsingKeyFrames timeline = null;
                            var definition = definitions.Where(x => x.Interpolator is inkanimMarginInterpolator).FirstOrDefault(defaultValue: null);

                            if (definition == null)
                            {
                                timeline = new ThicknessAnimationUsingKeyFrames();
                                definitions.Add(new inkControlAnimationDefiniton()
                                {
                                    Interpolator = animMargin,
                                    Timelines = new List<AnimationTimeline>(new [] { timeline }),
                                    Paths = new List<PropertyPath>(new[] { new PropertyPath(inkControl.MarginProperty) }),
                                    Target = "element" + element.GetHashCode()
                                });
                            }
                            else
                            {
                                timeline = (ThicknessAnimationUsingKeyFrames)definition.Timelines[0];
                            }

                            if (animI.StartDelay != 0)
                            {
                                timeline.KeyFrames.Add(ToThicknessKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animMargin.StartValue, 0));
                            }
                            timeline.KeyFrames.Add(ToThicknessKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animMargin.StartValue, animMargin.StartDelay));
                            timeline.KeyFrames.Add(ToThicknessKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animMargin.EndValue, animMargin.StartDelay + animMargin.Duration));
                        }

                        if (animI is inkanimSizeInterpolator animSize)
                        {
                            DoubleAnimationUsingKeyFrames widthTimeline = null;
                            DoubleAnimationUsingKeyFrames heightTimeline = null;
                            var definition = definitions.Where(x => x.Interpolator is inkanimSizeInterpolator).FirstOrDefault(defaultValue: null);

                            if (definition == null)
                            {
                                widthTimeline = new DoubleAnimationUsingKeyFrames();
                                heightTimeline = new DoubleAnimationUsingKeyFrames();
                                definitions.Add(new inkControlAnimationDefiniton()
                                {
                                    Interpolator = animSize,
                                    Timelines = new List<AnimationTimeline>(new [] { widthTimeline, heightTimeline }),
                                    Paths = new List<PropertyPath>(new [] { new PropertyPath(inkControl.WidthProperty), new PropertyPath(inkControl.HeightProperty) }),
                                    Target = "element" + element.GetHashCode()
                                });
                            }
                            else
                            {
                                widthTimeline = (DoubleAnimationUsingKeyFrames)definition.Timelines[0];
                                heightTimeline = (DoubleAnimationUsingKeyFrames)definition.Timelines[1];
                            }

                            if (animI.StartDelay != 0)
                            {
                                widthTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animSize.StartValue.X, 0));
                            }
                            widthTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animSize.StartValue.X, animSize.StartDelay));
                            widthTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animSize.EndValue.X, animSize.StartDelay + animSize.Duration));

                            if (animI.StartDelay != 0)
                            {
                                heightTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animSize.StartValue.Y, 0));
                            }
                            heightTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animSize.StartValue.Y, animSize.StartDelay));
                            heightTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animSize.EndValue.Y, animSize.StartDelay + animSize.Duration));
                        }

                        if (animI is inkanimRotationInterpolator animRot)
                        {
                            DoubleAnimationUsingKeyFrames timeline = null;
                            var definition = definitions.Where(x => x.Interpolator is inkanimRotationInterpolator).FirstOrDefault(defaultValue: null);

                            if (definition == null)
                            {
                                timeline = new DoubleAnimationUsingKeyFrames();
                                definitions.Add(new inkControlAnimationDefiniton()
                                {
                                    Interpolator = animRot,
                                    Timelines = new List<AnimationTimeline>(new[] { timeline }),
                                    Paths = new List<PropertyPath>(new[] { new PropertyPath(RotateTransform.AngleProperty) }),
                                    Target = "rotation" + element.GetHashCode()
                                });
                            }
                            else
                            {
                                timeline = (DoubleAnimationUsingKeyFrames)definition.Timelines[0];
                            }

                            var d = new DoubleAnimationUsingKeyFrames();
                            if (animI.StartDelay != 0)
                            {
                                timeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animRot.StartValue, 0));
                            }
                            timeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animRot.StartValue, animRot.StartDelay));
                            timeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animRot.EndValue, animRot.StartDelay + animRot.Duration));
                        }

                        if (animI is inkanimTranslationInterpolator animTrnsl)
                        {
                            DoubleAnimationUsingKeyFrames xTimeline = null;
                            DoubleAnimationUsingKeyFrames yTimeline = null;
                            var definition = definitions.Where(x => x.Interpolator is inkanimTranslationInterpolator).FirstOrDefault(defaultValue: null);

                            if (definition == null)
                            {
                                xTimeline = new DoubleAnimationUsingKeyFrames();
                                yTimeline = new DoubleAnimationUsingKeyFrames();
                                definitions.Add(new inkControlAnimationDefiniton()
                                {
                                    Interpolator = animTrnsl,
                                    Timelines = new List<AnimationTimeline>(new[] { xTimeline, yTimeline }),
                                    Paths = new List<PropertyPath>(new[] { new PropertyPath(TranslateTransform.XProperty), new PropertyPath(TranslateTransform.YProperty) }),
                                    Target = "translation" + element.GetHashCode()
                                });
                            }
                            else
                            {
                                xTimeline = (DoubleAnimationUsingKeyFrames)definition.Timelines[0];
                                yTimeline = (DoubleAnimationUsingKeyFrames)definition.Timelines[1];
                            }

                            if (animI.StartDelay != 0)
                            {
                                xTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsl.StartValue.X, 0));
                            }
                            xTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsl.StartValue.X, animTrnsl.StartDelay));
                            xTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsl.EndValue.X, animTrnsl.StartDelay + animTrnsl.Duration));

                            if (animI.StartDelay != 0)
                            {
                                yTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsl.StartValue.Y, 0));
                            }
                            yTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsl.StartValue.Y, animTrnsl.StartDelay));
                            yTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animTrnsl.EndValue.Y, animTrnsl.StartDelay + animTrnsl.Duration));
                        }

                        if (animI is inkanimScaleInterpolator animScale)
                        {
                            DoubleAnimationUsingKeyFrames xTimeline = null;
                            DoubleAnimationUsingKeyFrames yTimeline = null;
                            var definition = definitions.Where(x => x.Interpolator is inkanimScaleInterpolator).FirstOrDefault(defaultValue: null);

                            if (definition == null)
                            {
                                xTimeline = new DoubleAnimationUsingKeyFrames();
                                yTimeline = new DoubleAnimationUsingKeyFrames();
                                definitions.Add(new inkControlAnimationDefiniton()
                                {
                                    Interpolator = animScale,
                                    Timelines = new List<AnimationTimeline>(new[] { xTimeline, yTimeline }),
                                    Paths = new List<PropertyPath>(new[] { new PropertyPath(ScaleTransform.ScaleXProperty), new PropertyPath(ScaleTransform.ScaleYProperty) }),
                                    Target = "scale" + element.GetHashCode()
                                });
                            }
                            else
                            {
                                xTimeline = (DoubleAnimationUsingKeyFrames)definition.Timelines[0];
                                yTimeline = (DoubleAnimationUsingKeyFrames)definition.Timelines[1];
                            }

                            if (animI.StartDelay != 0)
                            {
                                xTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animScale.StartValue.X, 0));
                            }
                            xTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animScale.StartValue.X, animScale.StartDelay));
                            xTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animScale.EndValue.X, animScale.StartDelay + animScale.Duration));

                            if (animI.StartDelay != 0)
                            {
                                yTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animScale.StartValue.Y, 0));
                            }
                            yTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animScale.StartValue.Y, animScale.StartDelay));
                            yTimeline.KeyFrames.Add(ToDoubleKeyframe(animI.InterpolationType.Value, animI.InterpolationMode.Value, animScale.EndValue.Y, animScale.StartDelay + animScale.Duration));

   
                        }
                    }

                    foreach (var definition in definitions)
                    {
                        foreach (var timeline in definition.Timelines)
                        {
                            timeline.FillBehavior = FillBehavior.HoldEnd;
                            Storyboard.Children.Add(timeline);
                            Storyboard.SetTargetName(timeline, definition.Target);
                            Storyboard.SetTargetProperty(timeline, definition.Paths[definition.Timelines.IndexOf(timeline)]);
                        }
                    }
                }
            }
        }

        public ICommand PlayCommand { get; set; }
        //public bool CanPlay() => Storyboard != null && Storyboard.GetCurrentState() == ClockState.Stopped;
        public void Play() => Storyboard.Begin(WidgetView, true);

        public ICommand StopCommand { get; set; }
        //public bool CanStop() => Storyboard != null && Storyboard.GetCurrentState() != ClockState.Stopped;
        public void Stop() => Storyboard.Stop(WidgetView);

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
