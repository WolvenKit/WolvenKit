using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGodModeSharedState : gameIGameSystemReplicatedState
	{
		private CArray<gameGodModeSharedStateData> _datas;

		[Ordinal(0)] 
		[RED("datas")] 
		public CArray<gameGodModeSharedStateData> Datas
		{
			get
			{
				if (_datas == null)
				{
					_datas = (CArray<gameGodModeSharedStateData>) CR2WTypeManager.Create("array:gameGodModeSharedStateData", "datas", cr2w, this);
				}
				return _datas;
			}
			set
			{
				if (_datas == value)
				{
					return;
				}
				_datas = value;
				PropertySet(this);
			}
		}

		public gameGodModeSharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
