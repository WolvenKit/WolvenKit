using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InitiateScanner : redEvent
	{
		private CInt32 _trespasserEntryIndex;

		[Ordinal(0)] 
		[RED("trespasserEntryIndex")] 
		public CInt32 TrespasserEntryIndex
		{
			get
			{
				if (_trespasserEntryIndex == null)
				{
					_trespasserEntryIndex = (CInt32) CR2WTypeManager.Create("Int32", "trespasserEntryIndex", cr2w, this);
				}
				return _trespasserEntryIndex;
			}
			set
			{
				if (_trespasserEntryIndex == value)
				{
					return;
				}
				_trespasserEntryIndex = value;
				PropertySet(this);
			}
		}

		public InitiateScanner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
