using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerQuickHackDescription : ScannerChunk
	{
		private CHandle<QuickhackData> _quickHackDescription;

		[Ordinal(0)] 
		[RED("QuickHackDescription")] 
		public CHandle<QuickhackData> QuickHackDescription
		{
			get
			{
				if (_quickHackDescription == null)
				{
					_quickHackDescription = (CHandle<QuickhackData>) CR2WTypeManager.Create("handle:QuickhackData", "QuickHackDescription", cr2w, this);
				}
				return _quickHackDescription;
			}
			set
			{
				if (_quickHackDescription == value)
				{
					return;
				}
				_quickHackDescription = value;
				PropertySet(this);
			}
		}

		public ScannerQuickHackDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
