using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootstepDecalMaterialsMap : audioAudioMetadata
	{
		private CFloat _closestDecalDetectionRadius;
		private CArray<audioFootstepDecalMaterialEntry> _entries;

		[Ordinal(1)] 
		[RED("closestDecalDetectionRadius")] 
		public CFloat ClosestDecalDetectionRadius
		{
			get
			{
				if (_closestDecalDetectionRadius == null)
				{
					_closestDecalDetectionRadius = (CFloat) CR2WTypeManager.Create("Float", "closestDecalDetectionRadius", cr2w, this);
				}
				return _closestDecalDetectionRadius;
			}
			set
			{
				if (_closestDecalDetectionRadius == value)
				{
					return;
				}
				_closestDecalDetectionRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<audioFootstepDecalMaterialEntry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<audioFootstepDecalMaterialEntry>) CR2WTypeManager.Create("array:audioFootstepDecalMaterialEntry", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		public audioFootstepDecalMaterialsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
