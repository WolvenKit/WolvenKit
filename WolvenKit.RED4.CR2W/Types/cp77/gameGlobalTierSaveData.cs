using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGlobalTierSaveData : CVariable
	{
		private CEnum<gameGlobalTierSubtype> _subtype;
		private CHandle<gameSceneTierData> _data;

		[Ordinal(0)] 
		[RED("subtype")] 
		public CEnum<gameGlobalTierSubtype> Subtype
		{
			get
			{
				if (_subtype == null)
				{
					_subtype = (CEnum<gameGlobalTierSubtype>) CR2WTypeManager.Create("gameGlobalTierSubtype", "subtype", cr2w, this);
				}
				return _subtype;
			}
			set
			{
				if (_subtype == value)
				{
					return;
				}
				_subtype = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<gameSceneTierData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<gameSceneTierData>) CR2WTypeManager.Create("handle:gameSceneTierData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public gameGlobalTierSaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
