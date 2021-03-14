using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFoleyNPCAppearanceMappingMetadata : audioAudioMetadata
	{
		private CName _fallbackMetadata;
		private CArray<audioAppearanceToNPCMetadata> _nPCsPerAppearance;
		private CArray<audioVisualTagToNPCMetadata> _nPCsPerMainMaterial;
		private CArray<audioVisualTagToNPCMetadata> _nPCsPerAdditive;

		[Ordinal(1)] 
		[RED("fallbackMetadata")] 
		public CName FallbackMetadata
		{
			get
			{
				if (_fallbackMetadata == null)
				{
					_fallbackMetadata = (CName) CR2WTypeManager.Create("CName", "fallbackMetadata", cr2w, this);
				}
				return _fallbackMetadata;
			}
			set
			{
				if (_fallbackMetadata == value)
				{
					return;
				}
				_fallbackMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("NPCsPerAppearance")] 
		public CArray<audioAppearanceToNPCMetadata> NPCsPerAppearance
		{
			get
			{
				if (_nPCsPerAppearance == null)
				{
					_nPCsPerAppearance = (CArray<audioAppearanceToNPCMetadata>) CR2WTypeManager.Create("array:audioAppearanceToNPCMetadata", "NPCsPerAppearance", cr2w, this);
				}
				return _nPCsPerAppearance;
			}
			set
			{
				if (_nPCsPerAppearance == value)
				{
					return;
				}
				_nPCsPerAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("NPCsPerMainMaterial")] 
		public CArray<audioVisualTagToNPCMetadata> NPCsPerMainMaterial
		{
			get
			{
				if (_nPCsPerMainMaterial == null)
				{
					_nPCsPerMainMaterial = (CArray<audioVisualTagToNPCMetadata>) CR2WTypeManager.Create("array:audioVisualTagToNPCMetadata", "NPCsPerMainMaterial", cr2w, this);
				}
				return _nPCsPerMainMaterial;
			}
			set
			{
				if (_nPCsPerMainMaterial == value)
				{
					return;
				}
				_nPCsPerMainMaterial = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("NPCsPerAdditive")] 
		public CArray<audioVisualTagToNPCMetadata> NPCsPerAdditive
		{
			get
			{
				if (_nPCsPerAdditive == null)
				{
					_nPCsPerAdditive = (CArray<audioVisualTagToNPCMetadata>) CR2WTypeManager.Create("array:audioVisualTagToNPCMetadata", "NPCsPerAdditive", cr2w, this);
				}
				return _nPCsPerAdditive;
			}
			set
			{
				if (_nPCsPerAdditive == value)
				{
					return;
				}
				_nPCsPerAdditive = value;
				PropertySet(this);
			}
		}

		public audioFoleyNPCAppearanceMappingMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
