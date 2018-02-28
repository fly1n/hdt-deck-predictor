﻿using Hearthstone_Deck_Tracker.Hearthstone;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace DeckPredictor
{
	public interface IPredictor
	{
		ReadOnlyCollection<PredictedCardInfo> PredictedCards { get; }
	}
}
