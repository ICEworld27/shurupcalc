using System;
namespace CalcCS.Expressions
{
    /// <summary>
    /// Операция остаток от деления
    /// </summary>
    class ModuloOperation : BinaryOperation
    {
        /// <summary>
        /// Конструктор
        /// Обычно наследуется без изменений в классах конкретных операций.
        /// </summary>
        /// <param name="left">левый операнд</param>
        /// <param name="right">правый операнд</param>
        public ModuloOperation(IExpression left, IExpression right) : base(left, right)
        { }

        public override double Calculate()
        {
            return ((int)Math.Round(_left.Calculate())) % ((int)Math.Round(_right.Calculate()));
        }
    }
}
