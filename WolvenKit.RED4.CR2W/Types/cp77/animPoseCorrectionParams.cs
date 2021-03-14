using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseCorrectionParams : CVariable
	{
		private animPoseCorrectionGroup _poseCorrectionGroup;
		private CFloat _blendDuration;

		[Ordinal(0)] 
		[RED("poseCorrectionGroup")] 
		public animPoseCorrectionGroup PoseCorrectionGroup
		{
			get
			{
				if (_poseCorrectionGroup == null)
				{
					_poseCorrectionGroup = (animPoseCorrectionGroup) CR2WTypeManager.Create("animPoseCorrectionGroup", "poseCorrectionGroup", cr2w, this);
				}
				return _poseCorrectionGroup;
			}
			set
			{
				if (_poseCorrectionGroup == value)
				{
					return;
				}
				_poseCorrectionGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("blendDuration")] 
		public CFloat BlendDuration
		{
			get
			{
				if (_blendDuration == null)
				{
					_blendDuration = (CFloat) CR2WTypeManager.Create("Float", "blendDuration", cr2w, this);
				}
				return _blendDuration;
			}
			set
			{
				if (_blendDuration == value)
				{
					return;
				}
				_blendDuration = value;
				PropertySet(this);
			}
		}

		public animPoseCorrectionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
