using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairModule : HUDModule
	{
		private CArray<CHandle<Crosshair>> _activeCrosshairs;

		[Ordinal(3)] 
		[RED("activeCrosshairs")] 
		public CArray<CHandle<Crosshair>> ActiveCrosshairs
		{
			get
			{
				if (_activeCrosshairs == null)
				{
					_activeCrosshairs = (CArray<CHandle<Crosshair>>) CR2WTypeManager.Create("array:handle:Crosshair", "activeCrosshairs", cr2w, this);
				}
				return _activeCrosshairs;
			}
			set
			{
				if (_activeCrosshairs == value)
				{
					return;
				}
				_activeCrosshairs = value;
				PropertySet(this);
			}
		}

		public CrosshairModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
