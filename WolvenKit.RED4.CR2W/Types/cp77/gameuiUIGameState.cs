using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiUIGameState : ISerializable
	{
		private CArray<CHandle<gameuiBaseUIData>> _uiData;

		[Ordinal(0)] 
		[RED("uiData")] 
		public CArray<CHandle<gameuiBaseUIData>> UiData
		{
			get
			{
				if (_uiData == null)
				{
					_uiData = (CArray<CHandle<gameuiBaseUIData>>) CR2WTypeManager.Create("array:handle:gameuiBaseUIData", "uiData", cr2w, this);
				}
				return _uiData;
			}
			set
			{
				if (_uiData == value)
				{
					return;
				}
				_uiData = value;
				PropertySet(this);
			}
		}

		public gameuiUIGameState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
