using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundConfigContainer : ISerializable
	{
		private CName _appearanceName;
		private CArray<entdismembermentWoundConfig> _wounds;

		[Ordinal(0)] 
		[RED("AppearanceName")] 
		public CName AppearanceName
		{
			get
			{
				if (_appearanceName == null)
				{
					_appearanceName = (CName) CR2WTypeManager.Create("CName", "AppearanceName", cr2w, this);
				}
				return _appearanceName;
			}
			set
			{
				if (_appearanceName == value)
				{
					return;
				}
				_appearanceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Wounds")] 
		public CArray<entdismembermentWoundConfig> Wounds
		{
			get
			{
				if (_wounds == null)
				{
					_wounds = (CArray<entdismembermentWoundConfig>) CR2WTypeManager.Create("array:entdismembermentWoundConfig", "Wounds", cr2w, this);
				}
				return _wounds;
			}
			set
			{
				if (_wounds == value)
				{
					return;
				}
				_wounds = value;
				PropertySet(this);
			}
		}

		public entdismembermentWoundConfigContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
