using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSceneTier2Data : gameSceneTierData
	{
		private CEnum<Tier2WalkType> _walkType;

		[Ordinal(2)] 
		[RED("walkType")] 
		public CEnum<Tier2WalkType> WalkType
		{
			get
			{
				if (_walkType == null)
				{
					_walkType = (CEnum<Tier2WalkType>) CR2WTypeManager.Create("Tier2WalkType", "walkType", cr2w, this);
				}
				return _walkType;
			}
			set
			{
				if (_walkType == value)
				{
					return;
				}
				_walkType = value;
				PropertySet(this);
			}
		}

		public gameSceneTier2Data(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
