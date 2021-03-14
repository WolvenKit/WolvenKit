using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerSquadInfo : ScannerChunk
	{
		private CInt32 _numberOfSquadMembers;

		[Ordinal(0)] 
		[RED("numberOfSquadMembers")] 
		public CInt32 NumberOfSquadMembers
		{
			get
			{
				if (_numberOfSquadMembers == null)
				{
					_numberOfSquadMembers = (CInt32) CR2WTypeManager.Create("Int32", "numberOfSquadMembers", cr2w, this);
				}
				return _numberOfSquadMembers;
			}
			set
			{
				if (_numberOfSquadMembers == value)
				{
					return;
				}
				_numberOfSquadMembers = value;
				PropertySet(this);
			}
		}

		public ScannerSquadInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
