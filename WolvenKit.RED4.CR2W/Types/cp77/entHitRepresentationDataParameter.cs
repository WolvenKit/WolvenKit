using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entHitRepresentationDataParameter : entEntityParameter
	{
		private CArray<gameHitRepresentationOverride> _hitRepresentationOverrides;

		[Ordinal(0)] 
		[RED("hitRepresentationOverrides")] 
		public CArray<gameHitRepresentationOverride> HitRepresentationOverrides
		{
			get
			{
				if (_hitRepresentationOverrides == null)
				{
					_hitRepresentationOverrides = (CArray<gameHitRepresentationOverride>) CR2WTypeManager.Create("array:gameHitRepresentationOverride", "hitRepresentationOverrides", cr2w, this);
				}
				return _hitRepresentationOverrides;
			}
			set
			{
				if (_hitRepresentationOverrides == value)
				{
					return;
				}
				_hitRepresentationOverrides = value;
				PropertySet(this);
			}
		}

		public entHitRepresentationDataParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
