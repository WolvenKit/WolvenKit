using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionSelectSlot : gameIMuppetInputAction
	{
		private CInt32 _targetSlot;

		[Ordinal(0)] 
		[RED("targetSlot")] 
		public CInt32 TargetSlot
		{
			get
			{
				if (_targetSlot == null)
				{
					_targetSlot = (CInt32) CR2WTypeManager.Create("Int32", "targetSlot", cr2w, this);
				}
				return _targetSlot;
			}
			set
			{
				if (_targetSlot == value)
				{
					return;
				}
				_targetSlot = value;
				PropertySet(this);
			}
		}

		public gameMuppetInputActionSelectSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
