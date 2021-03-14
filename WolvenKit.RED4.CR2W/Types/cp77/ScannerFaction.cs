using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerFaction : ScannerChunk
	{
		private CString _faction;

		[Ordinal(0)] 
		[RED("faction")] 
		public CString Faction
		{
			get
			{
				if (_faction == null)
				{
					_faction = (CString) CR2WTypeManager.Create("String", "faction", cr2w, this);
				}
				return _faction;
			}
			set
			{
				if (_faction == value)
				{
					return;
				}
				_faction = value;
				PropertySet(this);
			}
		}

		public ScannerFaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
