﻿using System.Diagnostics;
using Compiler.Lexer.Tokenization.Attributes;

namespace Compiler.Lexer.Tokenization
{
    /// <summary>
    ///     An enumeration that identifies and describes various lexical tokens
    /// </summary>
    public enum TokenKind : ushort
    {

    #region Keywords

        /// <summary>
        ///     The 'enum' keyword which is used by the enum <see cref="Meta.AggregateKind"/>
        /// </summary>
        [Keyword("enum")]
        Enum,

        /// <summary>
        ///     The 'struct' keyword which is used by the structure <see cref="Meta.AggregateKind"/>
        /// </summary>
        [Keyword("struct")]
        Struct,

        /// <summary>
        ///     The 'message' keyword which is used by the message <see cref="Meta.AggregateKind"/>
        /// </summary>
        [Keyword("message")]
        Message,

        /// <summary>
        ///     The 'package' keyword which is reserved by the compiler
        /// </summary>
        [Keyword("package")]
        Package,

        /// <summary>
        ///     The 'package' keyword which is reserved by the compiler
        /// </summary>
        [Keyword("deprecated")]
        Deprecated,

    #endregion


    #region Literals

        WhiteSpace,
        Identifier,

        LineComment,

        /// <summary>
        ///     A single quoted string literal.
        /// </summary>
        StringLiteral,

        /// <summary>
        ///     A double quoted string literal.
        /// </summary>
        StringExpandable,

        /// <summary>
        ///     Any numerical literal token.
        /// </summary>
        Number,
        RealLiteral,
        EndOfFile,

    #endregion


    #region Symbols

        [Symbol('(')]
        OpenParenthesis,

        [Symbol(')')]
        CloseParenthesis,


        [Symbol('{')]
        OpenBrace,

        [Symbol('}')]
        CloseBrace,

        [Symbol('[')]
        OpenBracket,

        [Symbol(']')]
        CloseBracket,

        [Symbol(':')]
        Colon,

        [Symbol(';')]
        Semicolon,

        [Symbol(',')]
        Comma,

        [Symbol('.')]
        Dot,

        [Symbol('?')]
        QuestionMark,

        [Symbol('/')]
        Slash,

        /// <summary>
        ///     The assignment operator '='.
        /// </summary>
        [Symbol('=')]
        Eq

    #endregion
    }
}