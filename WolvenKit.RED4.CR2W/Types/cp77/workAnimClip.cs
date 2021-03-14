using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workAnimClip : workIEntry
	{
		private CName _animName;
		private CFloat _blendOutTime;

		[Ordinal(2)] 
		[RED("animName")] 
		public CName AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (CName) CR2WTypeManager.Create("CName", "animName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get
			{
				if (_blendOutTime == null)
				{
					_blendOutTime = (CFloat) CR2WTypeManager.Create("Float", "blendOutTime", cr2w, this);
				}
				return _blendOutTime;
			}
			set
			{
				if (_blendOutTime == value)
				{
					return;
				}
				_blendOutTime = value;
				PropertySet(this);
			}
		}

		public workAnimClip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
