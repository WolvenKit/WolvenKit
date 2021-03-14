using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationResource : CResource
	{
		private CArray<gameHitShapeContainer> _representations;
		private CArray<gameHitRepresentationVisualTaggedOverride> _overrides;

		[Ordinal(1)] 
		[RED("representations")] 
		public CArray<gameHitShapeContainer> Representations
		{
			get
			{
				if (_representations == null)
				{
					_representations = (CArray<gameHitShapeContainer>) CR2WTypeManager.Create("array:gameHitShapeContainer", "representations", cr2w, this);
				}
				return _representations;
			}
			set
			{
				if (_representations == value)
				{
					return;
				}
				_representations = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("overrides")] 
		public CArray<gameHitRepresentationVisualTaggedOverride> Overrides
		{
			get
			{
				if (_overrides == null)
				{
					_overrides = (CArray<gameHitRepresentationVisualTaggedOverride>) CR2WTypeManager.Create("array:gameHitRepresentationVisualTaggedOverride", "overrides", cr2w, this);
				}
				return _overrides;
			}
			set
			{
				if (_overrides == value)
				{
					return;
				}
				_overrides = value;
				PropertySet(this);
			}
		}

		public gameHitRepresentationResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
