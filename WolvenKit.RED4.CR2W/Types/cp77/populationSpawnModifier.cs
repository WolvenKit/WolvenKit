using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class populationSpawnModifier : populationModifier
	{
		private CHandle<gameObjectSpawnParameter> _spawnParameter;

		[Ordinal(0)] 
		[RED("spawnParameter")] 
		public CHandle<gameObjectSpawnParameter> SpawnParameter
		{
			get
			{
				if (_spawnParameter == null)
				{
					_spawnParameter = (CHandle<gameObjectSpawnParameter>) CR2WTypeManager.Create("handle:gameObjectSpawnParameter", "spawnParameter", cr2w, this);
				}
				return _spawnParameter;
			}
			set
			{
				if (_spawnParameter == value)
				{
					return;
				}
				_spawnParameter = value;
				PropertySet(this);
			}
		}

		public populationSpawnModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
