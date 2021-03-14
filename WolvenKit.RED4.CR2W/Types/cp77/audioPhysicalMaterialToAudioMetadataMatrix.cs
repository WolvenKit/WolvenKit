using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalMaterialToAudioMetadataMatrix : audioAudioMetadata
	{
		private CArray<audioAudioMaterialMetadataMapItem> _physicalToAudioMaterialAssignments;

		[Ordinal(1)] 
		[RED("physicalToAudioMaterialAssignments")] 
		public CArray<audioAudioMaterialMetadataMapItem> PhysicalToAudioMaterialAssignments
		{
			get
			{
				if (_physicalToAudioMaterialAssignments == null)
				{
					_physicalToAudioMaterialAssignments = (CArray<audioAudioMaterialMetadataMapItem>) CR2WTypeManager.Create("array:audioAudioMaterialMetadataMapItem", "physicalToAudioMaterialAssignments", cr2w, this);
				}
				return _physicalToAudioMaterialAssignments;
			}
			set
			{
				if (_physicalToAudioMaterialAssignments == value)
				{
					return;
				}
				_physicalToAudioMaterialAssignments = value;
				PropertySet(this);
			}
		}

		public audioPhysicalMaterialToAudioMetadataMatrix(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
