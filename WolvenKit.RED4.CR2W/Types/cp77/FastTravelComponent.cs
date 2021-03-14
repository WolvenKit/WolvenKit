using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelComponent : gameScriptableComponent
	{
		private CArray<CHandle<gameFastTravelPointData>> _fastTravelNodes;

		[Ordinal(5)] 
		[RED("fastTravelNodes")] 
		public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes
		{
			get
			{
				if (_fastTravelNodes == null)
				{
					_fastTravelNodes = (CArray<CHandle<gameFastTravelPointData>>) CR2WTypeManager.Create("array:handle:gameFastTravelPointData", "fastTravelNodes", cr2w, this);
				}
				return _fastTravelNodes;
			}
			set
			{
				if (_fastTravelNodes == value)
				{
					return;
				}
				_fastTravelNodes = value;
				PropertySet(this);
			}
		}

		public FastTravelComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
