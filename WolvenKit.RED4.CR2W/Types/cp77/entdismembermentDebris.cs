using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentDebris : CResource
	{
		private CArray<entdismembermentDebrisResourceItem> _items;

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<entdismembermentDebrisResourceItem> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		public entdismembermentDebris(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
