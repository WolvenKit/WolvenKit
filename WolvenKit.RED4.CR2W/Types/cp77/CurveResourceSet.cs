using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurveResourceSet : CResource
	{
		private CArray<CurveResourceSetEntry> _curveResources;

		[Ordinal(1)] 
		[RED("curveResources")] 
		public CArray<CurveResourceSetEntry> CurveResources
		{
			get
			{
				if (_curveResources == null)
				{
					_curveResources = (CArray<CurveResourceSetEntry>) CR2WTypeManager.Create("array:CurveResourceSetEntry", "curveResources", cr2w, this);
				}
				return _curveResources;
			}
			set
			{
				if (_curveResources == value)
				{
					return;
				}
				_curveResources = value;
				PropertySet(this);
			}
		}

		public CurveResourceSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
