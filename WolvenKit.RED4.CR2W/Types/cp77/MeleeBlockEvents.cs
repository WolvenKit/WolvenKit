using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeBlockEvents : MeleeEventsTransition
	{
		private CHandle<gameStatModifierData> _blockStatFlag;

		[Ordinal(0)] 
		[RED("blockStatFlag")] 
		public CHandle<gameStatModifierData> BlockStatFlag
		{
			get
			{
				if (_blockStatFlag == null)
				{
					_blockStatFlag = (CHandle<gameStatModifierData>) CR2WTypeManager.Create("handle:gameStatModifierData", "blockStatFlag", cr2w, this);
				}
				return _blockStatFlag;
			}
			set
			{
				if (_blockStatFlag == value)
				{
					return;
				}
				_blockStatFlag = value;
				PropertySet(this);
			}
		}

		public MeleeBlockEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
