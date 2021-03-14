using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVoicesetInputToBlock : CVariable
	{
		private CName _input;
		private CBool _blockSpecificVariation;
		private CUInt32 _variationNumber;

		[Ordinal(0)] 
		[RED("input")] 
		public CName Input
		{
			get
			{
				if (_input == null)
				{
					_input = (CName) CR2WTypeManager.Create("CName", "input", cr2w, this);
				}
				return _input;
			}
			set
			{
				if (_input == value)
				{
					return;
				}
				_input = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("blockSpecificVariation")] 
		public CBool BlockSpecificVariation
		{
			get
			{
				if (_blockSpecificVariation == null)
				{
					_blockSpecificVariation = (CBool) CR2WTypeManager.Create("Bool", "blockSpecificVariation", cr2w, this);
				}
				return _blockSpecificVariation;
			}
			set
			{
				if (_blockSpecificVariation == value)
				{
					return;
				}
				_blockSpecificVariation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("variationNumber")] 
		public CUInt32 VariationNumber
		{
			get
			{
				if (_variationNumber == null)
				{
					_variationNumber = (CUInt32) CR2WTypeManager.Create("Uint32", "variationNumber", cr2w, this);
				}
				return _variationNumber;
			}
			set
			{
				if (_variationNumber == value)
				{
					return;
				}
				_variationNumber = value;
				PropertySet(this);
			}
		}

		public entVoicesetInputToBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
