using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseBlendMethod_Mask : animIPoseBlendMethod
	{
		private CName _maskName;

		[Ordinal(0)] 
		[RED("maskName")] 
		public CName MaskName
		{
			get
			{
				if (_maskName == null)
				{
					_maskName = (CName) CR2WTypeManager.Create("CName", "maskName", cr2w, this);
				}
				return _maskName;
			}
			set
			{
				if (_maskName == value)
				{
					return;
				}
				_maskName = value;
				PropertySet(this);
			}
		}

		public animPoseBlendMethod_Mask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
