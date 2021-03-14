using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectedCoversData : IScriptable
	{
		private CArray<CUInt64> _selectedCovers;
		private CArray<CEnum<gamedataAIRingType>> _coverRingTypes;
		private CArray<CBool> _coversUseLOS;
		private CArray<CName> _sourcePresetName;

		[Ordinal(0)] 
		[RED("selectedCovers")] 
		public CArray<CUInt64> SelectedCovers
		{
			get
			{
				if (_selectedCovers == null)
				{
					_selectedCovers = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "selectedCovers", cr2w, this);
				}
				return _selectedCovers;
			}
			set
			{
				if (_selectedCovers == value)
				{
					return;
				}
				_selectedCovers = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("coverRingTypes")] 
		public CArray<CEnum<gamedataAIRingType>> CoverRingTypes
		{
			get
			{
				if (_coverRingTypes == null)
				{
					_coverRingTypes = (CArray<CEnum<gamedataAIRingType>>) CR2WTypeManager.Create("array:gamedataAIRingType", "coverRingTypes", cr2w, this);
				}
				return _coverRingTypes;
			}
			set
			{
				if (_coverRingTypes == value)
				{
					return;
				}
				_coverRingTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("coversUseLOS")] 
		public CArray<CBool> CoversUseLOS
		{
			get
			{
				if (_coversUseLOS == null)
				{
					_coversUseLOS = (CArray<CBool>) CR2WTypeManager.Create("array:Bool", "coversUseLOS", cr2w, this);
				}
				return _coversUseLOS;
			}
			set
			{
				if (_coversUseLOS == value)
				{
					return;
				}
				_coversUseLOS = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sourcePresetName")] 
		public CArray<CName> SourcePresetName
		{
			get
			{
				if (_sourcePresetName == null)
				{
					_sourcePresetName = (CArray<CName>) CR2WTypeManager.Create("array:CName", "sourcePresetName", cr2w, this);
				}
				return _sourcePresetName;
			}
			set
			{
				if (_sourcePresetName == value)
				{
					return;
				}
				_sourcePresetName = value;
				PropertySet(this);
			}
		}

		public AIbehaviorSelectedCoversData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
