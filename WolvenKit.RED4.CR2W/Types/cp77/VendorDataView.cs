using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorDataView : BackpackDataView
	{
		private CBool _isVendorGrid;
		private GameTime _openTime;

		[Ordinal(4)] 
		[RED("isVendorGrid")] 
		public CBool IsVendorGrid
		{
			get => GetProperty(ref _isVendorGrid);
			set => SetProperty(ref _isVendorGrid, value);
		}

		[Ordinal(5)] 
		[RED("openTime")] 
		public GameTime OpenTime
		{
			get => GetProperty(ref _openTime);
			set => SetProperty(ref _openTime, value);
		}

		public VendorDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
