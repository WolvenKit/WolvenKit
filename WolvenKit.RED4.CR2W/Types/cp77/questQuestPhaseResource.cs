using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questQuestPhaseResource : graphGraphResource
	{
		private CArray<questQuestPrefabEntry> _phasePrefabs;

		[Ordinal(2)] 
		[RED("phasePrefabs")] 
		public CArray<questQuestPrefabEntry> PhasePrefabs
		{
			get
			{
				if (_phasePrefabs == null)
				{
					_phasePrefabs = (CArray<questQuestPrefabEntry>) CR2WTypeManager.Create("array:questQuestPrefabEntry", "phasePrefabs", cr2w, this);
				}
				return _phasePrefabs;
			}
			set
			{
				if (_phasePrefabs == value)
				{
					return;
				}
				_phasePrefabs = value;
				PropertySet(this);
			}
		}

		public questQuestPhaseResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
