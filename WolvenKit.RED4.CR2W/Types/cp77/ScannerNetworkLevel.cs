using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerNetworkLevel : ScannerChunk
	{
		private CInt32 _networkLevel;

		[Ordinal(0)] 
		[RED("networkLevel")] 
		public CInt32 NetworkLevel
		{
			get
			{
				if (_networkLevel == null)
				{
					_networkLevel = (CInt32) CR2WTypeManager.Create("Int32", "networkLevel", cr2w, this);
				}
				return _networkLevel;
			}
			set
			{
				if (_networkLevel == value)
				{
					return;
				}
				_networkLevel = value;
				PropertySet(this);
			}
		}

		public ScannerNetworkLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
