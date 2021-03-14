using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InvisibleSceneStashControllerPS : ScriptableDeviceComponentPS
	{
		private CArray<gameItemID> _storedItems;

		[Ordinal(103)] 
		[RED("storedItems")] 
		public CArray<gameItemID> StoredItems
		{
			get
			{
				if (_storedItems == null)
				{
					_storedItems = (CArray<gameItemID>) CR2WTypeManager.Create("array:gameItemID", "storedItems", cr2w, this);
				}
				return _storedItems;
			}
			set
			{
				if (_storedItems == value)
				{
					return;
				}
				_storedItems = value;
				PropertySet(this);
			}
		}

		public InvisibleSceneStashControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
