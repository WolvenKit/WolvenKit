using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurveSet : CResource
	{
		private CArray<CurveSetEntry> _curves;

		[Ordinal(1)] 
		[RED("curves")] 
		public CArray<CurveSetEntry> Curves
		{
			get
			{
				if (_curves == null)
				{
					_curves = (CArray<CurveSetEntry>) CR2WTypeManager.Create("array:CurveSetEntry", "curves", cr2w, this);
				}
				return _curves;
			}
			set
			{
				if (_curves == value)
				{
					return;
				}
				_curves = value;
				PropertySet(this);
			}
		}

		public CurveSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
