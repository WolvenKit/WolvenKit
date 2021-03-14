using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animGenericAnimDatabase_AnimationData : CVariable
	{
		private CName _animationName;
		private CName _fallbackAnimationName;
		private CName _streamingContext;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fallbackAnimationName")] 
		public CName FallbackAnimationName
		{
			get
			{
				if (_fallbackAnimationName == null)
				{
					_fallbackAnimationName = (CName) CR2WTypeManager.Create("CName", "fallbackAnimationName", cr2w, this);
				}
				return _fallbackAnimationName;
			}
			set
			{
				if (_fallbackAnimationName == value)
				{
					return;
				}
				_fallbackAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("streamingContext")] 
		public CName StreamingContext
		{
			get
			{
				if (_streamingContext == null)
				{
					_streamingContext = (CName) CR2WTypeManager.Create("CName", "streamingContext", cr2w, this);
				}
				return _streamingContext;
			}
			set
			{
				if (_streamingContext == value)
				{
					return;
				}
				_streamingContext = value;
				PropertySet(this);
			}
		}

		public animGenericAnimDatabase_AnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
