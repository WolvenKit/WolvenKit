using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerRewireMapItem : CVariable
	{
		private CName _name;
		private CUInt32 _inputToBeRewiredVariationIndex;
		private CName _inputToBeActuallyPlayedName;
		private CUInt32 _inputToBeActuallyPlayedVariationIndex;
		private CBool _allowReuse;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inputToBeRewiredVariationIndex")] 
		public CUInt32 InputToBeRewiredVariationIndex
		{
			get
			{
				if (_inputToBeRewiredVariationIndex == null)
				{
					_inputToBeRewiredVariationIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "inputToBeRewiredVariationIndex", cr2w, this);
				}
				return _inputToBeRewiredVariationIndex;
			}
			set
			{
				if (_inputToBeRewiredVariationIndex == value)
				{
					return;
				}
				_inputToBeRewiredVariationIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inputToBeActuallyPlayedName")] 
		public CName InputToBeActuallyPlayedName
		{
			get
			{
				if (_inputToBeActuallyPlayedName == null)
				{
					_inputToBeActuallyPlayedName = (CName) CR2WTypeManager.Create("CName", "inputToBeActuallyPlayedName", cr2w, this);
				}
				return _inputToBeActuallyPlayedName;
			}
			set
			{
				if (_inputToBeActuallyPlayedName == value)
				{
					return;
				}
				_inputToBeActuallyPlayedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inputToBeActuallyPlayedVariationIndex")] 
		public CUInt32 InputToBeActuallyPlayedVariationIndex
		{
			get
			{
				if (_inputToBeActuallyPlayedVariationIndex == null)
				{
					_inputToBeActuallyPlayedVariationIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "inputToBeActuallyPlayedVariationIndex", cr2w, this);
				}
				return _inputToBeActuallyPlayedVariationIndex;
			}
			set
			{
				if (_inputToBeActuallyPlayedVariationIndex == value)
				{
					return;
				}
				_inputToBeActuallyPlayedVariationIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("allowReuse")] 
		public CBool AllowReuse
		{
			get
			{
				if (_allowReuse == null)
				{
					_allowReuse = (CBool) CR2WTypeManager.Create("Bool", "allowReuse", cr2w, this);
				}
				return _allowReuse;
			}
			set
			{
				if (_allowReuse == value)
				{
					return;
				}
				_allowReuse = value;
				PropertySet(this);
			}
		}

		public audioVoiceTriggerRewireMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
