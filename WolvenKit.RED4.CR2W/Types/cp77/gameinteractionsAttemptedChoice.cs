using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsAttemptedChoice : CVariable
	{
		private CInt32 _choiceIdx;
		private CEnum<gameinteractionsvisEVisualizerType> _visualizerType;
		private CBool _isSuccess;
		private gameinteractionsChoice _choice;

		[Ordinal(0)] 
		[RED("choiceIdx")] 
		public CInt32 ChoiceIdx
		{
			get
			{
				if (_choiceIdx == null)
				{
					_choiceIdx = (CInt32) CR2WTypeManager.Create("Int32", "choiceIdx", cr2w, this);
				}
				return _choiceIdx;
			}
			set
			{
				if (_choiceIdx == value)
				{
					return;
				}
				_choiceIdx = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visualizerType")] 
		public CEnum<gameinteractionsvisEVisualizerType> VisualizerType
		{
			get
			{
				if (_visualizerType == null)
				{
					_visualizerType = (CEnum<gameinteractionsvisEVisualizerType>) CR2WTypeManager.Create("gameinteractionsvisEVisualizerType", "visualizerType", cr2w, this);
				}
				return _visualizerType;
			}
			set
			{
				if (_visualizerType == value)
				{
					return;
				}
				_visualizerType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isSuccess")] 
		public CBool IsSuccess
		{
			get
			{
				if (_isSuccess == null)
				{
					_isSuccess = (CBool) CR2WTypeManager.Create("Bool", "isSuccess", cr2w, this);
				}
				return _isSuccess;
			}
			set
			{
				if (_isSuccess == value)
				{
					return;
				}
				_isSuccess = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("choice")] 
		public gameinteractionsChoice Choice
		{
			get
			{
				if (_choice == null)
				{
					_choice = (gameinteractionsChoice) CR2WTypeManager.Create("gameinteractionsChoice", "choice", cr2w, this);
				}
				return _choice;
			}
			set
			{
				if (_choice == value)
				{
					return;
				}
				_choice = value;
				PropertySet(this);
			}
		}

		public gameinteractionsAttemptedChoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
