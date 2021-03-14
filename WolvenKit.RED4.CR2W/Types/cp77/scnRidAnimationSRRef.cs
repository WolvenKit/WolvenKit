using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidAnimationSRRef : CVariable
	{
		private scnRidResourceId _resourceId;
		private scnRidSerialNumber _animationSN;

		[Ordinal(0)] 
		[RED("resourceId")] 
		public scnRidResourceId ResourceId
		{
			get
			{
				if (_resourceId == null)
				{
					_resourceId = (scnRidResourceId) CR2WTypeManager.Create("scnRidResourceId", "resourceId", cr2w, this);
				}
				return _resourceId;
			}
			set
			{
				if (_resourceId == value)
				{
					return;
				}
				_resourceId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animationSN")] 
		public scnRidSerialNumber AnimationSN
		{
			get
			{
				if (_animationSN == null)
				{
					_animationSN = (scnRidSerialNumber) CR2WTypeManager.Create("scnRidSerialNumber", "animationSN", cr2w, this);
				}
				return _animationSN;
			}
			set
			{
				if (_animationSN == value)
				{
					return;
				}
				_animationSN = value;
				PropertySet(this);
			}
		}

		public scnRidAnimationSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
