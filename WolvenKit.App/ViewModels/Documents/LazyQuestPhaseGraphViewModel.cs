using WolvenKit.App.Factories;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public class LazyQuestPhaseGraphViewModel : RedDocumentTabViewModel
{
    private readonly questQuestPhaseResource _data;
    private readonly IChunkViewmodelFactory _chunkViewmodelFactory;
    private readonly INodeWrapperFactory _nodeWrapperFactory;
    private bool _isMaterializing;

    public LazyQuestPhaseGraphViewModel(
        questQuestPhaseResource data,
        RedDocumentViewModel parent,
        IChunkViewmodelFactory chunkViewmodelFactory,
        INodeWrapperFactory nodeWrapperFactory)
        : base(parent, "Quest Phase Editor")
    {
        _data = data;
        _chunkViewmodelFactory = chunkViewmodelFactory;
        _nodeWrapperFactory = nodeWrapperFactory;
    }

    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;

    public override RedDocumentItemType GetContentType() => RedDocumentItemType.Questphase;

    public override void Load()
    {
        if (_isMaterializing)
        {
            return;
        }

        var index = Parent.TabItemViewModels.IndexOf(this);
        if (index < 0)
        {
            return;
        }

        _isMaterializing = true;

        var materialized = new QuestPhaseGraphViewModel(_data, Parent, _chunkViewmodelFactory, _nodeWrapperFactory, FilePath);

        Parent.TabItemViewModels[index] = materialized;
        Parent.SelectedIndex = index;
        Parent.SelectedTabItemViewModel = materialized;
    }
}
