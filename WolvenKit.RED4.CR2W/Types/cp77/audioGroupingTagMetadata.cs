using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGroupingTagMetadata : audioAudioMetadata
	{
		private CName _shape;
		private CEnum<audioClassificationMethod> _classificationMethod;
		private CName _inputEmitterName;
		private CArray<CName> _inputEventNames;
		private CArray<CName> _inputTags;
		private CName _outputEventId;
		private CFloat _minimalGroupCount;
		private CFloat _fullGroupCount;

		[Ordinal(1)] 
		[RED("shape")] 
		public CName Shape
		{
			get
			{
				if (_shape == null)
				{
					_shape = (CName) CR2WTypeManager.Create("CName", "shape", cr2w, this);
				}
				return _shape;
			}
			set
			{
				if (_shape == value)
				{
					return;
				}
				_shape = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("classificationMethod")] 
		public CEnum<audioClassificationMethod> ClassificationMethod
		{
			get
			{
				if (_classificationMethod == null)
				{
					_classificationMethod = (CEnum<audioClassificationMethod>) CR2WTypeManager.Create("audioClassificationMethod", "classificationMethod", cr2w, this);
				}
				return _classificationMethod;
			}
			set
			{
				if (_classificationMethod == value)
				{
					return;
				}
				_classificationMethod = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inputEmitterName")] 
		public CName InputEmitterName
		{
			get
			{
				if (_inputEmitterName == null)
				{
					_inputEmitterName = (CName) CR2WTypeManager.Create("CName", "inputEmitterName", cr2w, this);
				}
				return _inputEmitterName;
			}
			set
			{
				if (_inputEmitterName == value)
				{
					return;
				}
				_inputEmitterName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("inputEventNames")] 
		public CArray<CName> InputEventNames
		{
			get
			{
				if (_inputEventNames == null)
				{
					_inputEventNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "inputEventNames", cr2w, this);
				}
				return _inputEventNames;
			}
			set
			{
				if (_inputEventNames == value)
				{
					return;
				}
				_inputEventNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("inputTags")] 
		public CArray<CName> InputTags
		{
			get
			{
				if (_inputTags == null)
				{
					_inputTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "inputTags", cr2w, this);
				}
				return _inputTags;
			}
			set
			{
				if (_inputTags == value)
				{
					return;
				}
				_inputTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("outputEventId")] 
		public CName OutputEventId
		{
			get
			{
				if (_outputEventId == null)
				{
					_outputEventId = (CName) CR2WTypeManager.Create("CName", "outputEventId", cr2w, this);
				}
				return _outputEventId;
			}
			set
			{
				if (_outputEventId == value)
				{
					return;
				}
				_outputEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("minimalGroupCount")] 
		public CFloat MinimalGroupCount
		{
			get
			{
				if (_minimalGroupCount == null)
				{
					_minimalGroupCount = (CFloat) CR2WTypeManager.Create("Float", "minimalGroupCount", cr2w, this);
				}
				return _minimalGroupCount;
			}
			set
			{
				if (_minimalGroupCount == value)
				{
					return;
				}
				_minimalGroupCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("fullGroupCount")] 
		public CFloat FullGroupCount
		{
			get
			{
				if (_fullGroupCount == null)
				{
					_fullGroupCount = (CFloat) CR2WTypeManager.Create("Float", "fullGroupCount", cr2w, this);
				}
				return _fullGroupCount;
			}
			set
			{
				if (_fullGroupCount == value)
				{
					return;
				}
				_fullGroupCount = value;
				PropertySet(this);
			}
		}

		public audioGroupingTagMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
