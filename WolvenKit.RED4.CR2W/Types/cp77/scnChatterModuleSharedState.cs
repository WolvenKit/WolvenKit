using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChatterModuleSharedState : ISerializable
	{
		private CArray<CHandle<scnChatter>> _chatterHistory;

		[Ordinal(0)] 
		[RED("chatterHistory")] 
		public CArray<CHandle<scnChatter>> ChatterHistory
		{
			get
			{
				if (_chatterHistory == null)
				{
					_chatterHistory = (CArray<CHandle<scnChatter>>) CR2WTypeManager.Create("array:handle:scnChatter", "chatterHistory", cr2w, this);
				}
				return _chatterHistory;
			}
			set
			{
				if (_chatterHistory == value)
				{
					return;
				}
				_chatterHistory = value;
				PropertySet(this);
			}
		}

		public scnChatterModuleSharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
