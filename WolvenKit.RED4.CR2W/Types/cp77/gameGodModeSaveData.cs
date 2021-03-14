using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGodModeSaveData : ISerializable
	{
		private CArray<gameGodModeSaveEntityData> _gods;

		[Ordinal(0)] 
		[RED("gods")] 
		public CArray<gameGodModeSaveEntityData> Gods
		{
			get
			{
				if (_gods == null)
				{
					_gods = (CArray<gameGodModeSaveEntityData>) CR2WTypeManager.Create("array:gameGodModeSaveEntityData", "gods", cr2w, this);
				}
				return _gods;
			}
			set
			{
				if (_gods == value)
				{
					return;
				}
				_gods = value;
				PropertySet(this);
			}
		}

		public gameGodModeSaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
