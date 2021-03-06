// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Custom model training result. </summary>
    internal partial class TrainResult_internal
    {
        /// <summary> Initializes a new instance of TrainResult_internal. </summary>
        internal TrainResult_internal()
        {
        }

        /// <summary> Initializes a new instance of TrainResult_internal. </summary>
        /// <param name="trainingDocuments"> List of the documents used to train the model and any errors reported in each document. </param>
        /// <param name="fields"> List of fields used to train the model and the train operation error reported by each. </param>
        /// <param name="averageModelAccuracy"> Average accuracy. </param>
        /// <param name="errors"> Errors returned during the training operation. </param>
        internal TrainResult_internal(IList<TrainingDocumentInfo> trainingDocuments, IList<FieldPredictionAccuracy> fields, float? averageModelAccuracy, IList<FormRecognizerError> errors)
        {
            TrainingDocuments = trainingDocuments;
            Fields = fields;
            AverageModelAccuracy = averageModelAccuracy;
            Errors = errors;
        }

        /// <summary> List of the documents used to train the model and any errors reported in each document. </summary>
        public IList<TrainingDocumentInfo> TrainingDocuments { get; internal set; } = new List<TrainingDocumentInfo>();
        /// <summary> List of fields used to train the model and the train operation error reported by each. </summary>
        public IList<FieldPredictionAccuracy> Fields { get; internal set; }
        /// <summary> Average accuracy. </summary>
        public float? AverageModelAccuracy { get; internal set; }
        /// <summary> Errors returned during the training operation. </summary>
        public IList<FormRecognizerError> Errors { get; internal set; }
    }
}
