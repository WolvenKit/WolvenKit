using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerResistances : ScannerChunk
	{
		private CArray<ScannerStatDetails> _resists;

		[Ordinal(0)] 
		[RED("resists")] 
		public CArray<ScannerStatDetails> Resists
		{
			get
			{
				if (_resists == null)
				{
					_resists = (CArray<ScannerStatDetails>) CR2WTypeManager.Create("array:ScannerStatDetails", "resists", cr2w, this);
				}
				return _resists;
			}
			set
			{
				if (_resists == value)
				{
					return;
				}
				_resists = value;
				PropertySet(this);
			}
		}

		public ScannerResistances(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
