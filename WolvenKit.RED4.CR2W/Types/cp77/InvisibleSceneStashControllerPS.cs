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
			get => GetProperty(ref _storedItems);
			set => SetProperty(ref _storedItems, value);
		}

		public InvisibleSceneStashControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
