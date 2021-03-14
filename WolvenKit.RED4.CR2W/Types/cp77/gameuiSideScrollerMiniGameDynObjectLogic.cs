using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameDynObjectLogic : inkWidgetLogicController
	{
		private CUInt32 _spawnPoolSize;

		[Ordinal(1)] 
		[RED("spawnPoolSize")] 
		public CUInt32 SpawnPoolSize
		{
			get
			{
				if (_spawnPoolSize == null)
				{
					_spawnPoolSize = (CUInt32) CR2WTypeManager.Create("Uint32", "spawnPoolSize", cr2w, this);
				}
				return _spawnPoolSize;
			}
			set
			{
				if (_spawnPoolSize == value)
				{
					return;
				}
				_spawnPoolSize = value;
				PropertySet(this);
			}
		}

		public gameuiSideScrollerMiniGameDynObjectLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
