using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entGarmentParameter : entEntityParameter
	{
		private CArray<entGarmentParameterComponentData> _componentsData;
		private garmentCollarAreaParams _collarArea;
		private CDateTime _lastUpdateDateTime;

		[Ordinal(0)] 
		[RED("componentsData")] 
		public CArray<entGarmentParameterComponentData> ComponentsData
		{
			get
			{
				if (_componentsData == null)
				{
					_componentsData = (CArray<entGarmentParameterComponentData>) CR2WTypeManager.Create("array:entGarmentParameterComponentData", "componentsData", cr2w, this);
				}
				return _componentsData;
			}
			set
			{
				if (_componentsData == value)
				{
					return;
				}
				_componentsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("collarArea")] 
		public garmentCollarAreaParams CollarArea
		{
			get
			{
				if (_collarArea == null)
				{
					_collarArea = (garmentCollarAreaParams) CR2WTypeManager.Create("garmentCollarAreaParams", "collarArea", cr2w, this);
				}
				return _collarArea;
			}
			set
			{
				if (_collarArea == value)
				{
					return;
				}
				_collarArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lastUpdateDateTime")] 
		public CDateTime LastUpdateDateTime
		{
			get
			{
				if (_lastUpdateDateTime == null)
				{
					_lastUpdateDateTime = (CDateTime) CR2WTypeManager.Create("CDateTime", "lastUpdateDateTime", cr2w, this);
				}
				return _lastUpdateDateTime;
			}
			set
			{
				if (_lastUpdateDateTime == value)
				{
					return;
				}
				_lastUpdateDateTime = value;
				PropertySet(this);
			}
		}

		public entGarmentParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
