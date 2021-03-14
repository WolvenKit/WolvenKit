using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorTextureAnimation : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _initialFrame;
		private CHandle<IEvaluatorFloat> _animationSpeed;
		private CEnum<ETextureAnimationMode> _animationMode;

		[Ordinal(4)] 
		[RED("initialFrame")] 
		public CHandle<IEvaluatorFloat> InitialFrame
		{
			get
			{
				if (_initialFrame == null)
				{
					_initialFrame = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "initialFrame", cr2w, this);
				}
				return _initialFrame;
			}
			set
			{
				if (_initialFrame == value)
				{
					return;
				}
				_initialFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("animationSpeed")] 
		public CHandle<IEvaluatorFloat> AnimationSpeed
		{
			get
			{
				if (_animationSpeed == null)
				{
					_animationSpeed = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "animationSpeed", cr2w, this);
				}
				return _animationSpeed;
			}
			set
			{
				if (_animationSpeed == value)
				{
					return;
				}
				_animationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("animationMode")] 
		public CEnum<ETextureAnimationMode> AnimationMode
		{
			get
			{
				if (_animationMode == null)
				{
					_animationMode = (CEnum<ETextureAnimationMode>) CR2WTypeManager.Create("ETextureAnimationMode", "animationMode", cr2w, this);
				}
				return _animationMode;
			}
			set
			{
				if (_animationMode == value)
				{
					return;
				}
				_animationMode = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorTextureAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
