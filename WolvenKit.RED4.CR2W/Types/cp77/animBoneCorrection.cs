using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animBoneCorrection : CVariable
	{
		private CName _boneName;
		private Quaternion _additiveCorrection;

		[Ordinal(0)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get
			{
				if (_boneName == null)
				{
					_boneName = (CName) CR2WTypeManager.Create("CName", "boneName", cr2w, this);
				}
				return _boneName;
			}
			set
			{
				if (_boneName == value)
				{
					return;
				}
				_boneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("additiveCorrection")] 
		public Quaternion AdditiveCorrection
		{
			get
			{
				if (_additiveCorrection == null)
				{
					_additiveCorrection = (Quaternion) CR2WTypeManager.Create("Quaternion", "additiveCorrection", cr2w, this);
				}
				return _additiveCorrection;
			}
			set
			{
				if (_additiveCorrection == value)
				{
					return;
				}
				_additiveCorrection = value;
				PropertySet(this);
			}
		}

		public animBoneCorrection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
