using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class C4ControllerPS : ExplosiveDeviceControllerPS
	{
		private CName _itemTweakDBString;

		[Ordinal(119)] 
		[RED("itemTweakDBString")] 
		public CName ItemTweakDBString
		{
			get
			{
				if (_itemTweakDBString == null)
				{
					_itemTweakDBString = (CName) CR2WTypeManager.Create("CName", "itemTweakDBString", cr2w, this);
				}
				return _itemTweakDBString;
			}
			set
			{
				if (_itemTweakDBString == value)
				{
					return;
				}
				_itemTweakDBString = value;
				PropertySet(this);
			}
		}

		public C4ControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
