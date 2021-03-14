using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimationImportInfo : CVariable
	{
		private CEnum<animAnimationType> _animationType;
		private CEnum<animcompressionBufferTypePreset> _bufferType;
		private CEnum<animcompressionQualityPreset> _compressionPreset;
		private CEnum<animcompressionFrameratePreset> _frameratePreset;
		private CEnum<animEMotionExtractionCompressionType> _motionExtractionCompression;

		[Ordinal(0)] 
		[RED("AnimationType")] 
		public CEnum<animAnimationType> AnimationType
		{
			get
			{
				if (_animationType == null)
				{
					_animationType = (CEnum<animAnimationType>) CR2WTypeManager.Create("animAnimationType", "AnimationType", cr2w, this);
				}
				return _animationType;
			}
			set
			{
				if (_animationType == value)
				{
					return;
				}
				_animationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("BufferType")] 
		public CEnum<animcompressionBufferTypePreset> BufferType
		{
			get
			{
				if (_bufferType == null)
				{
					_bufferType = (CEnum<animcompressionBufferTypePreset>) CR2WTypeManager.Create("animcompressionBufferTypePreset", "BufferType", cr2w, this);
				}
				return _bufferType;
			}
			set
			{
				if (_bufferType == value)
				{
					return;
				}
				_bufferType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("CompressionPreset")] 
		public CEnum<animcompressionQualityPreset> CompressionPreset
		{
			get
			{
				if (_compressionPreset == null)
				{
					_compressionPreset = (CEnum<animcompressionQualityPreset>) CR2WTypeManager.Create("animcompressionQualityPreset", "CompressionPreset", cr2w, this);
				}
				return _compressionPreset;
			}
			set
			{
				if (_compressionPreset == value)
				{
					return;
				}
				_compressionPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("FrameratePreset")] 
		public CEnum<animcompressionFrameratePreset> FrameratePreset
		{
			get
			{
				if (_frameratePreset == null)
				{
					_frameratePreset = (CEnum<animcompressionFrameratePreset>) CR2WTypeManager.Create("animcompressionFrameratePreset", "FrameratePreset", cr2w, this);
				}
				return _frameratePreset;
			}
			set
			{
				if (_frameratePreset == value)
				{
					return;
				}
				_frameratePreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("MotionExtractionCompression")] 
		public CEnum<animEMotionExtractionCompressionType> MotionExtractionCompression
		{
			get
			{
				if (_motionExtractionCompression == null)
				{
					_motionExtractionCompression = (CEnum<animEMotionExtractionCompressionType>) CR2WTypeManager.Create("animEMotionExtractionCompressionType", "MotionExtractionCompression", cr2w, this);
				}
				return _motionExtractionCompression;
			}
			set
			{
				if (_motionExtractionCompression == value)
				{
					return;
				}
				_motionExtractionCompression = value;
				PropertySet(this);
			}
		}

		public animAnimationImportInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
